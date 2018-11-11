import * as React from 'react';
import Avatar from '@material-ui/core/Avatar';
import Button from '@material-ui/core/Button';
import FormControl from '@material-ui/core/FormControl';
import Input from '@material-ui/core/Input';
import InputLabel from '@material-ui/core/InputLabel';
import LockIcon from '@material-ui/icons/Lock';
import Paper from '@material-ui/core/Paper';
import Styles from '../styles/login-styles';
import Typography from '@material-ui/core/Typography';
import { WithStyles } from '@material-ui/core/styles';

export interface LoginProps extends WithStyles<typeof Styles> {

}

export interface LoginDispatchProps {
    authenticateUser: () => void;
}

export type Props = LoginProps & LoginDispatchProps;

const Login = (props: Props) => {
    const { classes } = props;

    return (
        <Paper className={classes.layout}>
            <Avatar>
                <LockIcon />
            </Avatar>
            <Typography variant="headline">Sign in</Typography>

            <FormControl margin="normal" required fullWidth>
                <InputLabel htmlFor="email">Username</InputLabel>
                <Input id="email" name="email" autoComplete="email" autoFocus />
            </FormControl>
            <FormControl margin="normal" required fullWidth>
                <InputLabel htmlFor="password">Password</InputLabel>
                <Input
                    name="password"
                    type="password"
                    id="password"
                    autoComplete="current-password"
                />

            </FormControl>
            <Button
                type="submit"
                fullWidth
                variant="raised"
                color="primary"
                onClick={() => props.authenticateUser()}
            >
                Sign in
            </Button>
        </Paper>
    );
};

export default Login;