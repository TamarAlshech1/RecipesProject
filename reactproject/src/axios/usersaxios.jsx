import axios from "axios"

let url = "https://localhost:44372/api/UserBLL/"

export const getAllUsers = async()=>{
    try 
       {
        //ניגש לכתובת של הפונקציה לפי שיטת הגישה שלה
        let data = await axios.get(`${url}myGetAllUsers`)
        return data
       }
       catch(er)
       {
        console.log("שגיאה בגישה לשרת"+er)
       }
}

export const addUsers = async(Uuser)=>{
    try 
       {
        
        //ניגש לכתובת של הפונקציה לפי שיטת הגישה שלה
        let data = await axios.post(`${url}myAddUser`,Uuser)
        return data
       }
       catch(er)
       {
        alert ("שגיאה בגישה לשרת"+er)
       }
}

//https://localhost:7220/api/RecepiBLL/myGetAllUsers

