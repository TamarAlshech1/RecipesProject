import userEvent from "@testing-library/user-event"
import { useEffect } from "react"
import { useContext } from "react"
import { useState } from "react"
import { useNavigate } from "react-router-dom"
import { getAllUsers } from "../axios/usersaxios"
import UserContext from "../userContext"



export const Conect = () => {
    //getAllUsers משתנה שיכיל את המשתנים שיחזרו מהפונקציה 
    const [dataUser, setDataUser] = useState({})
    //משתנה שיכיל את הנתונים שהמשתמש הכניס בפועל
    const [dataUser1, setDataUser1] = useState({})
    //context-משתנה שישמור את הנתונים שנשלוף מה
    let mycontext = useContext(UserContext)
    const myNevigate = useNavigate()

    //כשניטען את הקומפוננטה נירצה לגשת לשרת לשלוף את הנתונים
    async function fetchData() {
        //UserContext- userContext.js-המאגר שיצרנו בקובץ 
        //ריק , נשלוף נתונים ונכניס למאגר UserContext-אם מאגר המידע של ה
        if (mycontext.user1.length == 0) {
            //getAllUsers,usersaxios הכנסה לתוך משתנה את הנתונים שנשלפו מהפונקציה שכתבנו 
            let dataFromServer = await getAllUsers()
            //getAllUsersאת הרשימה של המשתמשים שנישלפו מה setDataUser הכנסה לתוך המשתנה
            setDataUser(dataFromServer.data)
            //עידכון ה-קון ברשימה שנישלפה עכשיו
            mycontext.setUse1(dataFromServer.data)
        }
        else {
            //את המידע שיש במאגר setDataUser-אם המאגר מלא, נציב ב
            setDataUser(mycontext)
        }
    }
    useEffect(() => {
        fetchData();
    }, [])

    const check = () => {
        for (let i = 0; i < dataUser.length; i++) {
            //בדיקה אם הוא מנהל
            if (dataUser1.id == mycontext.manegerid1 && dataUser1.name == mycontext.managername1) 
            {
                //  alert("אתה מנהל")//שולחת לעמוד משתמשים
                mycontext.setIsManager1(false)
                mycontext.setIsUser1(false)
                mycontext.setuserUsing(dataUser[i])
                myNevigate('/myRecepis')
                break
            }
            //מחובר ולא מנהל
            else if (dataUser[i].id == dataUser1.id && dataUser[i].name == dataUser1.name) 
            {
                mycontext.setIsUser1(false)
                mycontext.setuserUsing(dataUser[i])
                alert("אתה מחובר")
                myNevigate('/myRecepis')
                break
            }
            //אם לא מחובר בכלל
            else 
            {
                //נשלח אותו לעמוד הרשם
                myNevigate('/Hirashem')
            }
        }
    }
    // class="container mt-3"
    return  <div class="card" style={{width:600,borderWidth:"50%",marginLeft:"34%",marginTop:"7%",padding:"4%"}}>
        <br></br>
        <h4 style={{textAlign:"right"}}>התחברות</h4>
        <br></br>
        <label style={{textAlign:"right",fontSize:"14px"}} for="pwd">:קוד</label>
        <input type="text" class="form-control" placeholder="הכנס קוד" style={{textAlign:"right"}} onChange={(e) => setDataUser1({ ...dataUser1, id: e.target.value })}></input>
        <br></br>
        <label style={{textAlign:"right",fontSize:"14px"}} for="pwd">:שם</label>
        <input type="text" class="form-control" placeholder="הכנס שם"  style={{textAlign:"right"}} onChange={(e) => setDataUser1({ ...dataUser1, name: e.target.value })}></input>
        <br></br>
        <button class="btn btn-dark" style={{width:100}} onClick={() => check()}>התחבר</button>
    </div> 
}



