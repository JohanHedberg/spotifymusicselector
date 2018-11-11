import NotificationBar, {
    NotificationBarProps,
    NotificationBarDispatchProps
} from '../notification-bar';
import * as Actions from '../../actions/application-actions';
import { connect } from 'react-redux';
import { Dispatch } from 'redux';
import { StoreState } from '../../state/index';
import { withStyles, WithStyles } from '@material-ui/core/styles';
import Styles from '../../styles/notification-bar-styles';

interface ContainerProps extends WithStyles<typeof Styles> {

}

const mapStateToProps = (state: StoreState, ownProps: ContainerProps): NotificationBarProps => {
    return {
        message: state.application.notificationMessage,
        notificationBarIsVisible: state.application.notificationBarIsVisible,
        classes: ownProps.classes
    };
};

const mapDispatchToProps = (dispatch: Dispatch<Actions.ApplicationAction>): NotificationBarDispatchProps => {
    return {
        hideNotificationBar: () => dispatch(Actions.hideNotification())
    };
};

export default withStyles(Styles)(connect(mapStateToProps, mapDispatchToProps)(NotificationBar));