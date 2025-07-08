import logo from './logo.svg';
import './App.css';
import {BrowserRouter} from 'react-router-dom'
import { Myrouting } from './components/myrouting';
import './bootstrap.min.css'
import { Provider } from 'react-redux';
import { store } from './redux/store';
import { useState } from 'react';
import { MyProvider } from './userContext';

function App() {
  const [user,setUser]=useState([])
  const [isManager,setIsManager]=useState(true)
  const [isUser,setIsUser]=useState(true)
  const [userUsing, setuserUsing] = useState([])
  const arr=[]
  const idRec=""
  //הגדרת משתנה שיהיה מנהל
  let manegerid=100
  let managername="t"

  const myTranfer={
    user1:user,
    setUse1:setUser,
    isManager1:isManager,
    setIsManager1:setIsManager,
    manegerid1:manegerid,
    managername1:managername,
    isUser1:isUser,
    setIsUser1:setIsUser,
    userUsing:userUsing,
    setuserUsing: setuserUsing,
    arr:arr,
    idRec:idRec
    // maneger1:maneger,
    // setManeger1:setManeger
  }

  return (
    <div >
      <MyProvider value={myTranfer}>
    <Provider store={store}>
       <Myrouting>
       </Myrouting>
    </Provider>
    </MyProvider>
    </div>
   
  );
}

export default App;
