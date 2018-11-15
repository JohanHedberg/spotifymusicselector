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

export type QuestionsAction =
    SetActiveStep;