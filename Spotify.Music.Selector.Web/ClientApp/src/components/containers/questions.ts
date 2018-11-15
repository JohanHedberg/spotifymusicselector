import Questions, { QuestionsProps, QuestionsDispatchProps } from '../questions';
import Actions from '../../actions/all-actions';
import * as ApplicationAction from '../../actions/application-actions';
import * as QuestionsAction from '../../actions/questions-actions';
import { StoreState } from '../../state/index';
import { connect } from 'react-redux';
import { Dispatch } from 'redux';
import { WithStyles, withStyles } from '@material-ui/core/styles';
import Styles from '../../styles/questions-styles';
import TrackData from '../../types/track';

interface ContainerProps extends WithStyles<typeof Styles> {

}

export function mapStateToProps(state: StoreState, ownProps: ContainerProps): QuestionsProps {
    return {
        activeStep: state.questions.activeStep,
        selectedGenre: state.questions.genre,
        availableGenres: state.questions.availableGenres,
        classes: ownProps.classes
    };
}

export function mapDispatchToProps(
    dispatch: Dispatch<Actions>
): QuestionsDispatchProps {
    return {
        setSelectedGenre: (genre: string) => dispatch(QuestionsAction.setSelectedGenre(genre)),
        stepForward: (activeStep: number) => dispatch(QuestionsAction.setActiveStep(activeStep + 1)),
        stepBackward: (activeStep: number) => dispatch(QuestionsAction.setActiveStep(activeStep - 1)),
        showRecommendations: (tracks: Array<TrackData>) => dispatch(ApplicationAction.setRecommendations(tracks)),
        reset: () => {
            dispatch(QuestionsAction.setActiveStep(0));
            dispatch(ApplicationAction.setRecommendations([]));
        }
    };
}

export default withStyles(Styles)(connect(mapStateToProps, mapDispatchToProps)(Questions));