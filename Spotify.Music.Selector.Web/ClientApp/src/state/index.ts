import TrackData from '../types/track';

export interface ApplicationState {
    mainMenuIsVisible: boolean;
    notificationBarIsVisible: boolean;
    notificationMessage: string;
    recommendations: Array<TrackData>;
}

export interface QuestionsState {
    activeStep: number;
    genre: string;
    availableGenres: Array<string>;
}

export interface StoreState {
    application: ApplicationState;
    questions: QuestionsState;
}

export const InitialState: StoreState = {
    application: {
        mainMenuIsVisible: true,
        notificationBarIsVisible: false,
        notificationMessage: '',
        recommendations: []
    },
    questions: {
        activeStep: 0,
        genre: '',
        availableGenres: []
    }
};

export default StoreState;