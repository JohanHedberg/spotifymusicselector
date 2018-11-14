import TrackData from '../types/track';

export interface ApplicationState {
    mainMenuIsVisible: boolean;
    notificationBarIsVisible: boolean;
    notificationMessage: string;
    recommendations: Array<TrackData>;
}

export interface StoreState {
    application: ApplicationState;
}

export const InitialState: StoreState = {
    application: {
        mainMenuIsVisible: true,
        notificationBarIsVisible: false,
        notificationMessage: '',
        recommendations: []
    }
};

export default StoreState;