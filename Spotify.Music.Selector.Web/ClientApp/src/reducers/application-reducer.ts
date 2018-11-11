import * as Actions from '../actions/application-actions';
import { ApplicationState, InitialState } from '../state/index';

export default function applicationReducer(
    state: ApplicationState = InitialState.application,
    action: Actions.ApplicationAction): ApplicationState {

    switch (action.type) {
        case Actions.AUTHENTICATE_USER:
            return {
                ...state
            };

        case Actions.TOGGLE_MAIN_MENU:
            return {
                ...state,
                mainMenuIsVisible: !state.mainMenuIsVisible
            };

        case Actions.SHOW_NOTIFICATION:
            const showNotificationAction = action as Actions.ShowNotification;
            return {
                ...state,
                notificationBarIsVisible: true,
                notificationMessage: showNotificationAction.message
            };

        case Actions.HIDE_NOTIFICATION:
            return {
                ...state,
                notificationBarIsVisible: false,
                notificationMessage: ''
            };

        default:
            return state;
    }
}