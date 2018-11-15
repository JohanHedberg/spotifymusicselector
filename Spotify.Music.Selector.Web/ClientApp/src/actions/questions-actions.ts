export const SET_ACTIVE_STEP = 'SET_ACTIVE_STEP';
export type SET_ACTIVE_STEP = typeof SET_ACTIVE_STEP;

export interface SetActiveStep {
    type: SET_ACTIVE_STEP;
    index: number;
}

export function setActiveStep(index: number): SetActiveStep {
    return {
        type: SET_ACTIVE_STEP,
        index
    };
}

export const SET_AVAILABLE_GENRES = 'SET_AVAILABLE_GENRES';
export type SET_AVAILABLE_GENRES = typeof SET_AVAILABLE_GENRES;

export interface SetAvailableGenres {
    type: SET_AVAILABLE_GENRES;
    genres: Array<string>;
}

export function setAvailableGenres(genres: Array<string>): SetAvailableGenres {
    return {
        type: SET_AVAILABLE_GENRES,
        genres
    };
}

export const SET_SELECTED_GENRE = 'SET_SELECTED_GENRE';
export type SET_SELECTED_GENRE = typeof SET_SELECTED_GENRE;

export interface SetSelectedGenre {
    type: SET_SELECTED_GENRE;
    genre: string;
}

export function setSelectedGenre(genre: string): SetSelectedGenre {
    return {
        type: SET_SELECTED_GENRE,
        genre
    };
}

export type QuestionsAction =
    SetActiveStep | SetAvailableGenres | SetSelectedGenre;