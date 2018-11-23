import { createStyles, Theme } from '@material-ui/core';

const styles = ({ palette, spacing, breakpoints }: Theme) => createStyles({
    root: {

    },
    paper: {
        marginTop: 15,
        padding: 20,
        maxWidth: 700,
        marginLeft: 'auto',
        marginRight: 'auto'
    },
});

export default styles;