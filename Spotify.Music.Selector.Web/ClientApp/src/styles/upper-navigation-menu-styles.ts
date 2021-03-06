import { createStyles, Theme } from '@material-ui/core';

const styles = ({ palette, spacing, breakpoints }: Theme) => createStyles({
    root: {
        backgroundColor: palette.primary.main
    },
    title: {
        flex: 1,
        color: palette.primary.contrastText
    }
});

export default styles;