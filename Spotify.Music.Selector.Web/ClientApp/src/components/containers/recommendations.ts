import Recommendations, { RecommendationsProps, RecommendationsDispatchProps } from '../recommendations';
import * as Actions from '../../actions/application-actions';
import { StoreState } from '../../state';
import { connect } from 'react-redux';
import { Dispatch } from 'redux';
import { WithStyles, withStyles } from '@material-ui/core/styles';
import Styles from '../../styles/recommendations-styles';

interface ContainerProps extends WithStyles<typeof Styles> {

}

export function mapStateToProps(state: StoreState, ownProps: ContainerProps): RecommendationsProps {
    return {
        recommendations: state.application.recommendations,
        classes: ownProps.classes
    };
}

export function mapDispatchToProps(dispatch: Dispatch<Actions.ApplicationAction>): RecommendationsDispatchProps {
    return {

    };
}

export default withStyles(Styles)(connect(mapStateToProps, mapDispatchToProps)(Recommendations));