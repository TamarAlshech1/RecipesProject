import { useEffect } from "react"
import { useState } from "react"
import { useContext } from "react"
import UserContext from "../userContext"
import { getAllUsers } from "../axios/usersaxios"

export const UserList = ()=>{
     //משתנה שיכיל את המשתנים הדינאמים של הקומפוננטה
     const[userList,setUserList] = useState([])
     //context-משתנה שישמור את הנתונים שנשלוף מה
     let mycontext = useContext(UserContext)
     async function fetchData()
     {
        //UserContext- userContext.js-המאגר שיצרנו בקובץ 
        //ריק , נשלוף נתונים ונכניס למאגר UserContext-אם מאגר המידע של ה
        if(mycontext.user1.length != 0)
        {
              //getAllUsers,usersaxios הכנסה לתוך משתנה את הנתונים שנשלפו מהפונקציה שכתבנו 
              let dataFromServer = await getAllUsers()
              //getAllUsersאת הרשימה של המשתמשים שנישלפו מה setUserList הכנסה לתוך המשתנה
              setUserList(dataFromServer.data)
              //עידכון ה-קון ברשימה שנישלפה עכשיו
              mycontext.setUse1(dataFromServer.data)
        }
      //   else
      //   {
      //      // את המידע שיש במאגר setUserList-אם המאגר מלא, נציב ב
      //      setUserList(mycontext)
      //     alert("שגיאה בגישה לשרת!!!")
      //   }
     }
     useEffect(()=>{
        fetchData();
     },[])
     return <div class="container">
        <table class="table table-hover"  style={{textAlign:"right",marginTop:"10%"}}>
      <thead>
        <tr >
        <th>סיסמא</th>
        <th>כתובת מייל</th>
        <th>שם משפחה משתמש</th>
        <th>שם משתמש</th>
        <th>קוד משתמש</th>
        <br></br>
        <br></br>
        <br></br>
        </tr>
      </thead>
      
       
      <tbody>
      {userList.map(k=>(<tr><td>{k.password}</td><td>{k.email}</td><td>{k.fname}</td><td>{k.name}</td><td>{k.id}</td></tr>))}
      </tbody>
       </table>
   </div>
}





    









