import { useState } from "react"
import { useEffect } from "react"
import { useSelector } from "react-redux"
import { Navigate } from "react-router-dom"
import { useNavigate } from "react-router-dom"
import { getAllRecepis } from "../axios/recepiaxios"

export const ReceiList=()=>{
   //הגדרת משתנה ניתוב יזום
    const myNevigate = useNavigate()
    //משנה שיכיל את המשתנים הדינאמים של הקומפוננטה
    const[data,setdata] = useState([])
    // let g=useSelector(k=>k.recepyreducer.ReceiList)
    //כשניטען את הקומפוננטה נירצה לגשת לשרת לשלוף את הנתונים
    async function fetchData()
    {
       try{
        //getAllRecepis,recepiaxiosהכנסה לתוך משתנה את הנתונים שנשלפו מהפונקציה שכתבנו  
       let dataFromServer = await getAllRecepis()
       //getAllRecepisאת הרשימה של המתכונים שנישלפו מה setdata הכנסה לתוך המשתנה 
        setdata(dataFromServer.data)
        }
        catch(Exe){
          alert(Exe) 
        }
    }
    //fetchData בעת טעינת הקומפוננטה נזמן את הפונקציה 
    useEffect(()=>{
       fetchData();
    },[])
    return <div class="con">
      <div class="container-fuild empty-3 row" style={{marginLeft:"160px",marginTop:"75px"}}>
      {data.map(l=>(<div class="card col-sm-2" style={{borderColor:"black",padding:"10px",margin:"50px"}} ><p><p>{ <img class="card-img-top" src ={`https://localhost:44372/pic/${l.pic}`} alt="Card image"  ></img>}</p>
      <h4 class="card-title">{l.recepiname}</h4>
      <button  class="btn btn-dark" onClick={()=>myNevigate(`../myDatails/${l.id}`) }>פרטים נוספים</button>
      </p></div>))} </div>
       </div>
    

}
{/* <p>קוד מתכון---{l.id}</p> */}
{/* <p>{l.userTables}</p> */}