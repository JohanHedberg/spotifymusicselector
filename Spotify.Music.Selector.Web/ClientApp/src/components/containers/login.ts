import Login, {
    LoginProps,
    LoginDispatchProps
} from '../login';
import * as Actions from '../../actions/application-actions';
import { connect } from 'react-redux';
import { Dispatch } from 'redux';
import { StoreState } from '../../state/index';
import { withStyles, WithStyles } from '@material-ui/core/styles';
import Styles from '../../styles/login-styles';

interface ContainerProps extends WithStyles<typeof Styles> {

}

const mapStateToProps = (state: StoreState, ownProps: ContainerProps): LoginProps => {
    return {
        classes: ownProps.classes
    };
};

const mapDispatchToProps = (dispatch: Dispatch<Actions.ApplicationAction>): LoginDispatchProps => {
    return {
        authenticateUser: () => { dispatch(Actions.authenticateUser()); }
    };
};

export default withStyles(Styles)(connect(mapStateToProps, mapDispatchToProps)(Login));