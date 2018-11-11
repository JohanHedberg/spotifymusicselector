import { createStyles, Theme } from '@material-ui/core';

const styles = ({ palette, spacing, breakpoints }: Theme) => createStyles({
    root: {
        
    },
    close: {
        height: spacing.unit * 4,
        width: spacing.unit * 4
    }
});

export default styles;