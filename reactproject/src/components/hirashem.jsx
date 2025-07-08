import { useState } from "react"
import { useContext } from "react"
import { getAllUsers } from "../axios/usersaxios"
import { addUsers } from "../axios/usersaxios"
import { useNavigate } from "react-router-dom"
import UserContext from "../userContext"



export const Hirashem = ()=>{
     //משתנה שיכיל את הנתונים שהמשתמש הכניס בפועל
    const [addUser1,setaddUser1]= useState({})
     //context-משתנה שישמור את הנתונים שנשלוף מה
     let mycontext = useContext(UserContext)
     const myNevigate = useNavigate()
    const sign = async()=>{
        //משתנה מסוג אובייקט משתמש שיכיל את הנתונים שנכנסו
        const userobj = {
            "id":0,
            "name":addUser1.name,
            "fname":addUser1.fname,
            "email":addUser1.email,
            "password":addUser1.password
        }
        //משתנה שיכיל את האובייקט שנוסף
        let myAdd = await addUsers(userobj)
        //בדיקה אם המשתנה מלא
        if(myAdd.data == true)
          {
            alert("!!!!נוספת בהצלחה")
            mycontext.setIsUser1(false)
            //נשלח אותו לעמוד הבית
            myNevigate('../myRecepis')
           //לבדוק למה בהתחלה לא היה בתוך הערה mycontext.setIsUser1(false)
           // let datafromserver=await getAllUsers() 
           //נעדכן את הקון בשינוי שנוסף
           //mycontext.setUse1(datafromserver.data)
          }
          else
             alert("!!!!שגיאת שרת")
     }
    return <div   class="card" style={{width:600,borderWidth:"50%",marginLeft:"34%",marginTop:"7%",padding:"4%"}}>
        <br></br>
        {/* backgroundColor:"#EBC1C1" */}
        <h4 style={{textAlign:"right"}}> רישום</h4>
        <br></br>
        <label style={{textAlign:"right",fontSize:"14px"}} for="pwd">:שם</label>
        <input type="text" class="form-control" placeholder ="הכנס שם" style={{textAlign:"right"}} onChange={(e)=>setaddUser1({...addUser1,name:e.target.value})}></input>
        <br></br>
        <label style={{textAlign:"right",fontSize:"14px"}} for="pwd">:שם משפחה</label>
        <input type="text" class="form-control" placeholder ="הכנס שם משפחה" style={{textAlign:"right"}} onChange={(e)=>setaddUser1({...addUser1,fname:e.target.value})}></input>
        <br></br>
        <label style={{textAlign:"right",fontSize:"14px"}} for="pwd">:מייל</label>
        <input type="text" class="form-control" placeholder ="הכנס כתובת מייל" style={{textAlign:"right"}} onChange={(e)=>setaddUser1({...addUser1,email:e.target.value})}></input>
        <br></br>
        <label style={{textAlign:"right",fontSize:"14px"}} for="pwd">:סיסמא</label>
        <input type="text" class="form-control" placeholder ="הכנס סיסמא" style={{textAlign:"right"}} onChange={(e)=>setaddUser1({...addUser1,password:e.target.value})}></input> 
        <br></br>
        <button class="btn btn-dark" style={{width:100}} onClick={()=>sign()}>הרשם</button>

 </div>

}





//	הרשם יתווסף בפועל בשרת ותוצג הודעה מתאימה


