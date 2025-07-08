import { useDispatch } from "react-redux"
import { useContext } from "react"
import { useState } from "react"
import { useSelector } from "react-redux"
import UserContext from "../userContext"
import { getAllIEngrediens } from "../axios/engrediensaxios"
import { FillengrediensData } from "../redux/action/engrediensaction"

export const AddEngridiens=()=>{
    debugger
    let myId=0
    //מערך שיכיל את הרכיבים שנוסיף
    let arrEngridiens=[{}]
    //משתנה שישלח נתונים לרידקס
    let mydispatch = useDispatch()
    //ישמור את הרכיבים
    const [addEngridiens,setAddEngridiens] = useState([])
    //context-משתנה שישמור את הנתונים שנשלוף מה
    const mycontext = useContext(UserContext)
     //storeישלוף את הנתונים שהגדרנו ב
    let mySelector=useSelector(k=>k.EngrediensReducer.EngrediensList)

    const myplus=async()=>
    {
        
        if(mySelector.length>0)
            arrEngridiens=mySelector
        else
        {
            let result=await getAllIEngrediens()
            arrEngridiens=result.data
            mydispatch(FillengrediensData(result.data))
        }
        debugger
        let m=arrEngridiens.filter(l=>l.engrediensName==addEngridiens.engrediensName)
        if(m.length == 0)
            myId = 0
        else
            myId = m[0].idEngrediens
            //משתנה מסוג רכיבים למתכון
        let engridiensobj={
                "idForRecepi": 0,
                "idRecepi": mycontext.idRec,
                "idEngrediens": myId,
                "engrediensName": addEngridiens.engrediensName,
                "count": addEngridiens.count
        }
        //הוספת האוביקט למערך שהגדרנו באפ
        mycontext.arr.push(engridiensobj)
    }
    return <div>
        <input type="text" placeholder ="הכנס שם"  onChange={(e) => setAddEngridiens({ ...addEngridiens, engrediensName: e.target.value })}></input>
        <input type="text" placeholder ="הכנס כמות"  onChange={(e) => setAddEngridiens({ ...addEngridiens, count: e.target.value })}></input>
        <button onClick={()=>myplus()}>הוסף את הרכיב</button>
    </div>

}