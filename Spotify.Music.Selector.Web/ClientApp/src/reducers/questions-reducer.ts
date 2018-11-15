import * as Actions from '../actions/questions-actions';
import { QuestionsState, InitialState } from '../state';

export default function questionsReducer(
    state: QuestionsState = InitialState.questions,
    action: Actions.QuestionsAction): QuestionsState {

    switch (action.type) {
        case Actions.SET_ACTIVE_STEP:
            return {
                ...state,
                activeStep: action.index
            };

        case Actions.SET_AVAILABLE_GENRES:
            return {
                ...state,
                availableGenres: action.genres
            };

        case Actions.SET_SELECTED_GENRE:
            return {
                ...state,
                genre: action.genre
            };

        default:
            return state;
    }
}