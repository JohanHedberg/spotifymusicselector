import * as React from 'react';
import { WithStyles } from '@material-ui/core/styles';
import Stepper from '@material-ui/core/Stepper';
import Step from '@material-ui/core/Step';
import StepLabel from '@material-ui/core/StepLabel';
import Button from '@material-ui/core/Button';
import Typography from '@material-ui/core/Typography';
import Styles from '../styles/questions-styles';
import Paper from '@material-ui/core/Paper';
import Chip from '@material-ui/core/Chip';
import TrackData from '../types/track';
import MusicApi from '../api/music-api';
import Grid from '@material-ui/core/Grid';
import Divider from '@material-ui/core/Divider';
import MicIcon from '@material-ui/icons/SettingsVoice';

function getSteps() {
    return ['Favorite genre?', 'Coolest artist', 'Magic number'];
}

function getStepContent(stepIndex: number, props: Props) {
    const { classes } = props;

    switch (stepIndex) {
        case 0:
            return (
                <div>
                    <Typography
                        className={classes.questionTitle}
                        variant="headline"
                    >
                        Chose a genre of your liking...
                    </Typography>
                    <Grid
                        container
                        spacing={8}
                    >
                        {props.availableGenres.map(genre => {
                            const color = props.selectedGenre === genre ? 'secondary' : 'primary';

                            return (
                                <Grid item key={genre}>
                                    <Chip
                                        className={classes.chip}
                                        clickable
                                        label={genre}
                                        color={color}
                                        variant="default"
                                        icon={<MicIcon />}
                                        onClick={() => {
                                            props.setSelectedGenre(genre);
                                            props.stepForward(props.activeStep);
                                        }}
                                    />
                                </Grid>
                            );
                        })}
                    </Grid>
                </div>
            );

        case 1:
            return (
                <div>
                    <Typography
                        className={classes.questionTitle}
                        variant="headline"
                    >
                        Who is the coolest artist, like ever?
                    </Typography>
                </div>
            );

        case 2:
            return (
                <div>
                    <Typography
                        className={classes.questionTitle}
                        variant="headline"
                    >
                        From a range of one to five, how happy are you today?
                    </Typography>
                </div>
            );

        default:
            return (
                <div />
            );
    }
}

export interface QuestionsProps extends WithStyles<typeof Styles> {
    selectedGenre: string;
    activeStep: number;
    availableGenres: Array<string>;
}

export interface QuestionsDispatchProps {
    setSelectedGenre: (genre: string) => void;
    stepForward: (activeStep: number) => void;
    stepBackward: (activeStep: number) => void;
    showRecommendations: (tracks: Array<TrackData>) => void;
    reset: () => void;
}

export type Props = QuestionsProps & QuestionsDispatchProps;

const Questions = (props: Props) => {
    const { classes } = props;
    const steps = getSteps();
    const handleStepFoward = async () => {
        props.stepForward(props.activeStep);

        if (props.activeStep === steps.length - 1) {
            await RecommendMusic();
        }
    };

    const RecommendMusic = async () => {
        const recommendedTracks = await MusicApi.getRecommendations('./', props.selectedGenre);
        props.showRecommendations(recommendedTracks);
    };

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
                        <Typography className={classes.instructions}>All steps completed, enjoy your music!</Typography>
                        <Button onClick={props.reset}>Start all over</Button>
                    </div>
                ) : (
                        <div>
                            <div className={classes.question}>
                                {getStepContent(props.activeStep, props)}
                            </div>
                            <Divider />
                            <div className={classes.navigationButtonsContainer}>
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
                                    onClick={handleStepFoward}
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