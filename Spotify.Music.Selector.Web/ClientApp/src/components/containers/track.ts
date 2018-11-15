import Track, { TrackProps, TrackDispatchProps } from '../track';
import TrackData from '../../types/track';
import * as Actions from '../../actions/application-actions';
import { StoreState } from '../../state/index';
import { connect } from 'react-redux';
import { Dispatch } from 'redux';
import { WithStyles, withStyles } from '@material-ui/core/styles';
import Styles from '../../styles/track-styles';

interface ContainerProps extends WithStyles<typeof Styles> {
    track: TrackData;
}

export function mapStateToProps(state: StoreState, ownProps: ContainerProps): TrackProps {
    return {
        track: ownProps.track,
        classes: ownProps.classes
    };
}

export function mapDispatchToProps(dispatch: Dispatch<Actions.ApplicationAction>): TrackDispatchProps {
    return {

    };
}

export default withStyles(Styles)(connect(mapStateToProps, mapDispatchToProps)(Track));