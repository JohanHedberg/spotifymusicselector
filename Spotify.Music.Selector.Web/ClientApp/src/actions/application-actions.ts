export const TOGGLE_MAIN_MENU = 'TOGGLE_MAIN_MENU';
export type TOGGLE_MAIN_MENU = typeof TOGGLE_MAIN_MENU;

export interface ToggleMainMenu {
    type: TOGGLE_MAIN_MENU;
}

export function toggleMainMenu(): ToggleMainMenu {
    return {
        type: TOGGLE_MAIN_MENU
    };
}

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

export const AUTHENTICATE_USER = 'AUTHENTICATE_USER';
export type AUTHENTICATE_USER = typeof AUTHENTICATE_USER;

export interface AuthenticateUser {
    type: AUTHENTICATE_USER;
}

export function authenticateUser(): AuthenticateUser {
    return {
        type: AUTHENTICATE_USER
    };
}

export type ApplicationAction =
    ToggleMainMenu |
    AuthenticateUser |
    ShowNotification | HideNotification;