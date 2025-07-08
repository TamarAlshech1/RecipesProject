import axios from "axios"

let url = "https://localhost:44372/api/RecepiBLL/"

export const getAllRecepis = async()=>{
       try 
       {
        //ניגש לכתובת של הפונקציה לפי שיטת הגישה שלה
        let data = await axios.get(`${url}mygetallrecepi`)
        return data
       }
       catch(er)
       {
              console.log(er)
       }
}

export const addRecepis = async(recepy)=>{
       
       try 
       {
        //ניגש לכתובת של הפונקציה לפי שיטת הגישה שלה
        let data = await axios.post(`${url}myaddRecepis`,recepy)
        return data
       }
       catch(er)
       {
              alert("!!!!!!שגיאה בגישה לשרת!!!!")
             // console.log(er)
       }
}

