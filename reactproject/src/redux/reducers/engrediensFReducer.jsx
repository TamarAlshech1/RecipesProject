import {produce} from 'immer'

export const InitialState={
    //רשימה שנמלא מהשרת
    engrediensFList:[

    ]
}

export const engrediensFreducer= produce((state,action)=>{
    switch(action.type){
        case  'FILL_ENGREDIENS_F_DATA':state.engrediensFList = action.payload
          break;
          }
},InitialState)