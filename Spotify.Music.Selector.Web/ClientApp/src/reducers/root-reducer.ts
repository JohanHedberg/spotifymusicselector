import { combineReducers } from 'redux';
import application from './application-reducer';
import questions from './questions-reducer';

const rootReducer = combineReducers({
    application,
    questions
});

export default rootReducer;