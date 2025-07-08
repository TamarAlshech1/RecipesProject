import axios from "axios"

let url = "https://localhost:44372/api/EngrediensForRecepiBLL/"

export const Get_by_idRecepi = async(id)=>{
       try 
       {
        //ניגש לכתובת של הפונקציה לפי שיטת הגישה שלה
        let data = await axios.get(`${url}getByIdRecepi/${id}`)
        return data
       }
       catch(er)
       {
              console.log(er)
       }

}
//פונקצית הוספת רכיבים
export const addEngrediensToRecepi = async(obj)=>{
       try 
       {
        //ניגש לכתובת של הפונקציה לפי שיטת הגישה שלה
        let data = await axios.post(`${url}myAddEngrediens`,obj)
        return data
       }
       catch(er)
       {
              console.log(er)
       }
       
}
