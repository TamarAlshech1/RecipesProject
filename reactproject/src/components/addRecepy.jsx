import { useState } from "react"
import { useDispatch } from "react-redux"
import { addRecepis } from "../axios/recepiaxios"
import { FillRecepyData } from "../redux/action/recepyaction"
import { getAllRecepis } from "../axios/recepiaxios"
import { useContext } from "react"
import UserContext from "../userContext"
import { useNavigate } from "react-router-dom"
import { Link } from "react-router-dom"
import { Outlet } from "react-router-dom"
import { addEngrediensToRecepi } from "../axios/engredienForsaxios"

export const AddRecepy = () => {
    //משתנה שיכיל את הנתונים שהמשתמש הכניס בפועל
    const [addata, setAddata] = useState({})
    //משתנה שישלח נתונים לרידקס
    let mydispatch = useDispatch()
    //שליפת נתונים מהקונטקס
    let appGet = useContext(UserContext)
    let myNevigate = useNavigate()
    //let arr=[]

    const add = async () => {
        //משתנה מסוג אובייקט משתמש שיכיל את הנתונים שנכנסו
        let recepyobj = {
            "id": 0,
            "recepiname": addata.recepiname,
            "description": addata.description,
            "pic": addata.pic,
            "lavel": addata.lavel,
            "time": "10:10:10",
            "nummanot": addata.nummanot,
            "oraot": addata.oraot,
            "idUser": appGet.userUsing.id,
            "name": appGet.userUsing.name,
            "fname": appGet.userUsing.fname,
            "email": appGet.userUsing.email,
            "password": appGet.userUsing.password
        }
        //משתנה שיכיל את האובייקט שנוסף
        let myAdd = await addRecepis(recepyobj)
        if (myAdd.data != -1) {
            alert("!!!!נוסף בהצלחה")
           // appGet.id=myAdd.data
            appGet.idRec=myAdd.data
            // setAddata(myAdd.data)
           
        }
           let myAdd1 = await getAllRecepis()
           mydispatch(FillRecepyData(myAdd1.data))
    }

    const send = async () => {
        //פומקציה שמרעננת את הדף
        myNevigate('/AddRecepy')
    }

        const end = async () => {
            debugger
        let dataf= await addEngrediensToRecepi(appGet.arr)
        if(dataf.data!=0)
          alert("הוסיף")
    }

    return <div class="card" style={{ width: 600, borderWidth: "50%", marginLeft: "34%", marginTop: "7%", padding: "4%" }}>
        <br></br>
        <h4 style={{ textAlign: "right" }}>הוסף מתכון</h4>
        <br></br>
        <label style={{ textAlign: "right", fontSize: "14px" }} for="pwd">:שם מתכון</label>
        <input type="text" class="form-control" placeholder="הכנס שם מתכון" style={{ textAlign: "right" }} onChange={(e) => setAddata({ ...addata, recepiname: e.target.value })}></input>
        <br></br>
        <label style={{ textAlign: "right", fontSize: "14px" }} for="pwd">:תיאור</label>
        <input type="text" class="form-control" placeholder="הכנס  תיאור" style={{ textAlign: "right" }} onChange={(e) => setAddata({ ...addata, description: e.target.value })}></input>
        <br></br>
        <label style={{ textAlign: "right", fontSize: "14px" }} for="pwd">:תמונה</label>
        <input type="text" class="form-control" placeholder="הכנס  תמונה" style={{ textAlign: "right" }} onChange={(e) => setAddata({ ...addata, pic: e.target.value })}></input>
        <br></br>
        {/* <label style={{textAlign:"right",fontSize:"14px"}} for="pwd">:תמונה</label>
    <input type="file" class="form-control" placeholder ="הכנס  תמונה" style={{textAlign:"right"}} onChange={(e)=>setAddata({...addata,pic:e.target.value})}></input>
    <br></br> */}
        <label style={{ textAlign: "right", fontSize: "14px" }} for="pwd">:רמה</label>
        <input type="text" class="form-control" placeholder="הכנס רמה" style={{ textAlign: "right" }} onChange={(e) => setAddata({ ...addata, lavel: e.target.value })}></input>
        <br></br>
        <label style={{ textAlign: "right", fontSize: "14px" }} for="pwd">:מנות</label>
        <input type="text" class="form-control" placeholder="הכנס מספר מנות" style={{ textAlign: "right" }} onChange={(e) => setAddata({ ...addata, nummanot: e.target.value })}></input>
        <br></br>
        <label style={{ textAlign: "right", fontSize: "14px" }} for="pwd">:הוראות</label>
        <input type="text" class="form-control" placeholder="הכנס הוראות" style={{ textAlign: "right" }} onChange={(e) => setAddata({ ...addata, oraot: e.target.value })}></input>
        <br></br>
        <button class="btn btn-dark" style={{ width: 100 }} onClick={() => add()}>הוסף</button>
        <br></br>
        <button class="btn btn-dark" style={{ width: 50 }} onClick={() => send()}>+</button>
        <br></br>
        <Link  className="nav-link" to={'AddEngridiens'} >הוסף רכיבים</Link>
        <button class="btn btn-dark" style={{ width: 100 }} onClick={() => end()}>הוספת כל הרכיבים</button>
        <Outlet></Outlet>
    </div>
}



