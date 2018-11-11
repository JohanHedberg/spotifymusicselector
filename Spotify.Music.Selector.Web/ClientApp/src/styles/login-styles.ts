import { createStyles, Theme } from '@material-ui/core';

const styles = ({ palette, spacing, breakpoints }: Theme) => createStyles({
    layout: {
        width: 'auto',
        display: 'block', // Fix IE11 issue.
        marginLeft: spacing.unit * 3,
        marginRight: spacing.unit * 3,
        [breakpoints.up(400 + spacing.unit * 3 * 2)]: {
            width: 400,
            marginLeft: 'auto',
            marginRight: 'auto',
        },
    },
    paper: {
        marginTop: spacing.unit * 8,
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        padding: `${spacing.unit * 2}px ${spacing.unit * 3}px ${spacing.unit * 3}px`,
    },
    avatar: {
        margin: spacing.unit,
        backgroundColor: palette.secondary.main,
    },
    form: {
        width: '100%', // Fix IE11 issue.
        marginTop: spacing.unit,
    },
    submit: {
        marginTop: spacing.unit * 3,
    }
});

export default styles;