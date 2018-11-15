import Home, { HomeProps, HomeDispatchProps } from '../home';
import * as Actions from '../../actions/application-actions';
import { StoreState } from '../../state';
import { connect } from 'react-redux';
import { Dispatch } from 'redux';
import { WithStyles, withStyles } from '@material-ui/core/styles';
import Styles from '../../styles/home-styles';

interface ContainerProps extends WithStyles<typeof Styles> {

}

export function mapStateToProps(state: StoreState, ownProps: ContainerProps): HomeProps {
    return {
        classes: ownProps.classes
    };
}

export function mapDispatchToProps(dispatch: Dispatch<Actions.ApplicationAction>): HomeDispatchProps {
    return {

    };
}

export default withStyles(Styles)(connect(mapStateToProps, mapDispatchToProps)(Home));