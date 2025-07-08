import {produce} from 'immer'


export const InitialState={
    ReceiList:[

    ]
}

export const recepyreducer = produce((state,action)=>{
    switch(action.type){
  case  'FILL_RECEPY_DATA':state.ReceiList = action.payload
    break;
  case  'ADD_RECEPY_DATA':state.ReceiList = action.payload
    break;
    }
   },InitialState)