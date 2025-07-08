import { Route } from "react-router-dom"
import { Routes } from "react-router-dom"
import { BrowserRouter } from "react-router-dom"
import { ReceiList } from "./home"
import { Datails } from "./datails"
import { MyNav } from "./myNav"
import { Home } from "./home"
import { Conect } from "./conect"
import { Hirashem } from "./hirashem"
import { UserList } from "./userList"
import { And } from "./and"
import { AddRecepy } from "./addRecepy"
import { AddEngridiens } from "./addEngridiens"

export const Myrouting=()=>{
    return <BrowserRouter>
     <div className='app' style={{direction:"rtl"}}><MyNav></MyNav></div>
    <Routes>
       <Route path="/" element={<ReceiList></ReceiList>}></Route>  
        <Route path="myRecepis" element={<ReceiList></ReceiList>}></Route>
        <Route path="myDatails/:id" element={<Datails></Datails>}></Route>
        <Route path="myConect" element={<Conect></Conect>}></Route>
        <Route path="Hirashem" element={<Hirashem></Hirashem>}></Route>
        <Route path="myUserList" element={<UserList></UserList>}></Route>
        <Route path="And" element={<And></And>}></Route>
        <Route path="AddRecepy" element={<AddRecepy></AddRecepy>}>
              <Route path="AddEngridiens" element={<AddEngridiens></AddEngridiens>}></Route>     
        </Route>
    </Routes>
    </BrowserRouter>

    
}