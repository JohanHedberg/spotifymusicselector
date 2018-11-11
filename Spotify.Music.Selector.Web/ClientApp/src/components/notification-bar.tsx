import * as React from 'react';
import { withStyles } from '@material-ui/core/styles';
import Snackbar from '@material-ui/core/Snackbar';
import IconButton from '@material-ui/core/IconButton';
import CloseIcon from '@material-ui/icons/Close';
import Styles from '../styles/notification-bar-styles';
import { WithStyles } from '@material-ui/core/styles';

export interface NotificationBarProps extends WithStyles<typeof Styles> {
    message: string;
    notificationBarIsVisible: boolean;
}

export interface NotificationBarDispatchProps {
    hideNotificationBar: () => void;
}

export type Props = NotificationBarProps & NotificationBarDispatchProps;

const NotificationBar = (props: Props) => {
    const { classes } = props;

    return (
        <Snackbar
            className={classes.root}
            anchorOrigin={{
                horizontal: 'left',
                vertical: 'top',
            }}
            autoHideDuration={6000}
            message={<span id="message-id">{props.message}</span>}
            onClose={props.hideNotificationBar}
            open={props.notificationBarIsVisible}
            action={[
                <IconButton
                    key="close"
                    aria-label="Close"
                    color="inherit"
                    onClick={props.hideNotificationBar}
                >
                    <CloseIcon />
                </IconButton>
            ]}
        />
    );
};

export default withStyles(Styles)(NotificationBar);