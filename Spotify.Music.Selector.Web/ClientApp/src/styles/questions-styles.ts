import { createStyles, Theme } from '@material-ui/core';

const styles = ({ palette, spacing, breakpoints }: Theme) => createStyles({
    root: {
        padding: 12,
    },
    paper: {
        padding: 20,
        maxWidth: 700,
    },
    backButton: {
        marginRight: spacing.unit,
    },
    instructions: {
        marginTop: spacing.unit,
        marginBottom: spacing.unit,
    },
});

export default styles;