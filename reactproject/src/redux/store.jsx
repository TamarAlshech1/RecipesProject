import { combineReducers } from "redux";
import { recepyreducer } from './reducers/recepyReducer.jsx';
import {EngrediensReducer} from './reducers/engrediensReducer.jsx'
import {createStore} from 'redux';
// import {reducer} from 'redux';


export const reducer = combineReducers({recepyreducer:recepyreducer,EngrediensReducer:EngrediensReducer})
export const store=createStore(reducer)
window.store = store