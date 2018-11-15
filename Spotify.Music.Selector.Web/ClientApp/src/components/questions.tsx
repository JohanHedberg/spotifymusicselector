import * as React from 'react';
import { WithStyles } from '@material-ui/core/styles';
import Stepper from '@material-ui/core/Stepper';
import Step from '@material-ui/core/Step';
import StepLabel from '@material-ui/core/StepLabel';
import Button from '@material-ui/core/Button';
import Typography from '@material-ui/core/Typography';
import Styles from '../styles/questions-styles';
import Paper from '@material-ui/core/Paper';

function getSteps() {
    return ['Favorite genre?', 'Coolest artist', 'Magic number'];
}

function getStepContent(stepIndex: number) {
    switch (stepIndex) {
        case 0:
            return 'Select campaign settings...';
        case 1:
            return 'What is an ad group anyways?';
        case 2:
            return 'This is the bit I really care about!';
        default:
            return 'Uknown stepIndex';
    }
}

export interface QuestionsProps extends WithStyles<typeof Styles> {
    activeStep: number;
}

export interface QuestionsDispatchProps {
    stepForward: (activeStep: number) => void;
    stepBackward: (activeStep: number) => void;
    reset: () => void;
}

export type Props = QuestionsProps & QuestionsDispatchProps;

const Questions = (props: Props) => {
    const { classes } = props;
    const steps = getSteps();

    return (
        <Paper 
            className={classes.paper}
            square
        >
            <Typography variant="h4" gutterBottom>
                Tell us about your taste?
                </Typography>
            <Stepper activeStep={props.activeStep} alternativeLabel>
                {steps.map(label => {
                    return (
                        <Step key={label}>
                            <StepLabel>{label}</StepLabel>
                        </Step>
                    );
                })}
            </Stepper>
            <div>
                {props.activeStep === steps.length ? (
                    <div>
                        <Typography className={classes.instructions}>All steps completed</Typography>
                        <Button onClick={props.reset}>Reset</Button>
                    </div>
                ) : (
                        <div>
                            <Typography
                                className={classes.instructions}
                            >
                                {getStepContent(props.activeStep)}
                            </Typography>
                            <div>
                                <Button
                                    disabled={props.activeStep === 0}
                                    onClick={() => props.stepBackward(props.activeStep)}
                                    className={classes.backButton}
                                >
                                    Back
                                </Button>
                                <Button
                                    variant="contained"
                                    color="primary"
                                    onClick={() => props.stepForward(props.activeStep)}
                                >
                                    {props.activeStep === steps.length - 1 ? 'Show Recommendations' : 'Next'}
                                </Button>
                            </div>
                        </div>
                    )}
            </div>
        </Paper>
    );
};

export default Questions;