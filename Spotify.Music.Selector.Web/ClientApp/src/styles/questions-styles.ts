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
    question: {
        marginBottom: 20
    },
    questionTitle: {
        textAlign: 'center',
        marginBottom: 16
    },
    instructions: {
        marginTop: spacing.unit,
        marginBottom: spacing.unit,
    },
    navigationButtonsContainer: {
        marginTop: 20
    },
    chip: {
        // backgroundColor: palette.primary.main,
        // color: palette.common.white
    },
    chipAvatar: {
        // backgroundColor: palette.primary.main,
        // color: palette.common.white
    }
});

export default styles;