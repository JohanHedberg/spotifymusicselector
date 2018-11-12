import TrackData from '../types/track';

export const SHOW_NOTIFICATION = 'SHOW_NOTIFICATION';
export type SHOW_NOTIFICATION = typeof SHOW_NOTIFICATION;

export interface ShowNotification {
    type: SHOW_NOTIFICATION;
    message: string;
}

export function showNotification(message: string): ShowNotification {
    return {
        type: SHOW_NOTIFICATION,
        message
    };
}

export const SET_RECOMMENDATIONS = 'SET_RECOMMENDATIONS';
export type SET_RECOMMENDATIONS = typeof SET_RECOMMENDATIONS;

export interface SetRecommendations {
    type: SET_RECOMMENDATIONS;
    tracks: Array<TrackData>;
}

export function setRecommendations(tracks: Array<TrackData>): SetRecommendations {
    return {
        type: SET_RECOMMENDATIONS,
        tracks
    };
}

export const HIDE_NOTIFICATION = 'HIDE_NOTIFICATION';
export type HIDE_NOTIFICATION = typeof HIDE_NOTIFICATION;

export interface HideNotification {
    type: HIDE_NOTIFICATION;
}

export function hideNotification(): HideNotification {
    return {
        type: HIDE_NOTIFICATION
    };
}

export type ApplicationAction =
    ShowNotification | HideNotification |
    SetRecommendations;