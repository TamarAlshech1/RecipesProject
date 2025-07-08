import {produce} from 'immer'

export const InitialState={
    EngrediensList:[

    ]
}

export const EngrediensReducer= produce((state,action)=>{
    switch(action.type){
        case  'FILL_ENGREDIENS_DATA':state.EngrediensList = action.payload
          break;
          }
},InitialState)