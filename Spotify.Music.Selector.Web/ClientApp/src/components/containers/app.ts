import App, { AppProps, AppDispatchProps } from '../app';
import * as Actions from '../../actions/application-actions';
import { StoreState } from '../../state/index';
import { connect } from 'react-redux';
import { Dispatch } from 'redux';
import { WithStyles, withStyles } from '@material-ui/core/styles';
import Styles from '../../styles/app-styles';

interface ContainerProps extends WithStyles<typeof Styles> {

}

export function mapStateToProps(state: StoreState, ownProps: ContainerProps): AppProps {
    return {
        classes: ownProps.classes
    };
}

export function mapDispatchToProps(dispatch: Dispatch<Actions.ApplicationAction>): AppDispatchProps {
    return {

    };
}

export default withStyles(Styles)(connect(mapStateToProps, mapDispatchToProps)(App));