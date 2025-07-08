import { useEffect } from "react"
import { useDispatch } from "react-redux"
import { useSelector } from "react-redux"
import { useParams } from "react-router-dom"
import { useState } from "react"
import { getAllRecepis } from "../axios/recepiaxios"
import { Get_by_idRecepi } from "../axios/engredienForsaxios"
import { FillRecepyData } from "../redux/action/recepyaction"
import { FillengrediensData } from "../redux/action/engrediensaction"  


export const Datails=()=>{
    //משתנה שיכיל את המשתנים הדינאמים של הקומפוננטה
    const[dataRecepy,setDataRecepy] = useState([])
    const[dataEngrediens,setDataEngrediens] = useState([])
    //מקבל לתוכו את הid myDatailsששלחנו ל
    const params = useParams()
    //שליפה של הנתונים מהרידקס כלומר את כל המתכונים
    //storeישלוף את הנתונים שהגדרנו ב
    let f = useSelector(j=>j.recepyreducer.ReceiList)
     //משתנה שישלח נתונים לרידקס
    let mydispatch = useDispatch()
     //כשניטען את הקומפוננטה נירצה לגשת לשרת לשלוף את הנתונים
     async function fetchData()
       { 
          if(f.length==0)
          {
           // alert("נכנסתי לif")
           //getAllRecepis,recepiaxiosהכנסה לתוך משתנה את הנתונים שנשלפו מהפונקציה שכתבנו  
             let dataFromServer = await getAllRecepis()
           //getAllRecepisאת הרשימה של המתכונים שנישלפו מה setDataRecepy הכנסה לתוך המשתנה
             setDataRecepy(dataFromServer.data)
            //ונעדכן את הרידקס בשינוי
             mydispatch(FillRecepyData(dataFromServer.data))
          }
          else
          {
            //alert("נכנסתי לelse")
            setDataRecepy(f)
          }
       }
       async function fetchData1()
       { 
        let FromServer = await Get_by_idRecepi(params.id)
        setDataEngrediens(FromServer.data)
         mydispatch(FillengrediensData(FromServer.data))
       }
       //fetchData בעת טעינת הקומפוננטה נזמן את הפונקציה 
       useEffect(()=>{
        fetchData();
        fetchData1();
       },[])
       
       return <div class="container mt-3">
        {f.filter(o=>o.id==params.id).map(l=>(<div class="card" style={{width:600,borderColor:"black",marginLeft:"22%"}}>
                                                    <h2 class="card-title">{l.recepiname}</h2>
                                                    <img class="card-img-top" src ={`https://localhost:44372/pic/${l.pic}`} width="300" ></img>
                                                    <p>קוד מתכון---{l.id}</p>
                                                    <p>תיאור---{l.description}</p>
                                                    <p>רמה---{l.lavel}</p>
                                                    <p>זמן---{l.time}</p>
                                                    <p>מספר מנות---{l.nummanot}</p>
                                                    <p>קוד משתמש---{l.idUser}</p>
                                                    </div>))}
                                                    {dataEngrediens.map(k=>(<p><p>רכיבים</p>
                                                    {k.engrediensName}</p>))}
       </div>
    }















{/* להעביר לעמוד פרטים נוספים */}

 






















// export const ReceiList=()=>{
//     try{
//         let dataFromServer = await getAllRecepis()
//          setdata(dataFromServer.data)
//          }
//          catch(Exe){
//            alert(Exe) 
//          }
//      }
//      useEffect(()=>{
//          fetchData();
//       },[])
//      return <div>
//       {data.map(l=>(<p>{תיאור---{l.}}</p>))}
   
    
 
//     return <div> 
//       {data.map(l=>(<p><p>{<img src ={`https://localhost:7220/pic/${l.pic}`} width="300" height="300"></img>}</p>
//       <p>קוד מתכון---{l.id}</p>
//       <p>{l.recepiname}---שם מתכון</p>
//       <button onClick={()=>myNevigate(`../myDatails/${l.id}`)}>פרטים נוספים</button>
//       </p>))}