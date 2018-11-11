import UpperNavigationMenu, {
    UpperNavigationMenuProps,
    UpperNavigationMenuDispatchProps
} from '../upper-navigation-menu';
import * as Actions from '../../actions/application-actions';
import { connect } from 'react-redux';
import { Dispatch } from 'redux';
import { StoreState } from '../../state/index';
import { withStyles, WithStyles } from '@material-ui/core/styles';
import Styles from '../../styles/upper-navigation-menu-styles';

interface ContainerProps extends WithStyles<typeof Styles> {

}

const mapStateToProps = (state: StoreState, ownProps: ContainerProps): UpperNavigationMenuProps => {
    return {
        classes: ownProps.classes
    };
};

const mapDispatchToProps = (dispatch: Dispatch<Actions.ApplicationAction>): UpperNavigationMenuDispatchProps => {
    return {

    };
};

export default withStyles(Styles)(connect(mapStateToProps, mapDispatchToProps)(UpperNavigationMenu));