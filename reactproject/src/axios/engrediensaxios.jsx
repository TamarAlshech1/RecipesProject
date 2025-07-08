import axios from "axios"

let url = "https://localhost:44372/api/EngrediensBLL/"

export const getAllIEngrediens = async()=>{
       try 
       {
        //ניגש לכתובת של הפונקציה לפי שיטת הגישה שלה
        let data = await axios.get(`${url}myGetAllEngrediens`)
        return data
       }
       catch(er)
       {
              console.log(er)
       }
}