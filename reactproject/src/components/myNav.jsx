import { useContext } from "react"
import { Link } from "react-router-dom"
import UserContext from "../userContext"

export const MyNav=()=>{
    //Context-ישמור נתונים שנשלוף מה-
    const myCheck=useContext(UserContext)
   
    return <div>
    <nav className="navbar navbar-expand-md bg-dark navbar-dark">
   
        <a className="navbar-brand" href="#">מתכונים </a>

        <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#collapsibleNavbar">
            <span className="navbar-toggler-icon"></span>
        </button>
       
        <div className="collapse navbar-collapse" id="collapsibleNavbar" >
            <ul className="navbar-nav">
                <li className="nav-item">
                    {/* תגית a היא תגית המתאימה לקריאה לשרת אחר בשביל לעבור לקומפוננטה אחרת  */}
                    {/* כיוון שאנחנו באפליקצית עמוד יחיד אין צורך ואי אפשר להשתמש בתגית זו */}
                    {/* <a className="nav-link" href="https://netfree.link/shortcuts/">רשימת המשימות</a> */}
                    {/* <Link className="nav-link" to={'שם שבחרנו לקומפוננטה הרצויה'}>רשימת משימות</Link> */}
                    <Link className="nav-link" to={'myRecepis'}>דף הבית </Link>
                </li>
                <li className="nav-item">
                    <Link hidden={myCheck.isUser1} className="nav-link" to={'addRecepy'}> הוספת מתכון</Link>
                </li> 
                <li className="nav-item">
                    <Link className="nav-link" to={'myConect'}> התחבר</Link>
                </li> 
                <li className="nav-item">
                    <Link className="nav-link" to={'Hirashem'}> הרשם</Link>
                </li> 
                <li className="nav-item">
                    <Link hidden={myCheck.isManager1} className="nav-link" to={'myUserList'}> רשימת משתמשים</Link>
                </li> 
               
               
            </ul>
        </div>
    </nav>
</div>
}