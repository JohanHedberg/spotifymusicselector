import Questions, { QuestionsProps, QuestionsDispatchProps } from '../questions';
import * as Actions from '../../actions/questions-actions';
import { StoreState } from '../../state/index';
import { connect } from 'react-redux';
import { Dispatch } from 'redux';
import { WithStyles, withStyles } from '@material-ui/core/styles';
import Styles from '../../styles/questions-styles';

interface ContainerProps extends WithStyles<typeof Styles> {

}

export function mapStateToProps(state: StoreState, ownProps: ContainerProps): QuestionsProps {
    return {
        activeStep: state.questions.activeStep,
        classes: ownProps.classes
    };
}

export function mapDispatchToProps(dispatch: Dispatch<Actions.QuestionsAction>): QuestionsDispatchProps {
    return {
        stepForward: (activeStep: number) => dispatch(Actions.setActiveStep(activeStep + 1)),
        stepBackward: (activeStep: number) => dispatch(Actions.setActiveStep(activeStep - 1)),
        reset: () => dispatch(Actions.setActiveStep(0))
    };
}

export default withStyles(Styles)(connect(mapStateToProps, mapDispatchToProps)(Questions));