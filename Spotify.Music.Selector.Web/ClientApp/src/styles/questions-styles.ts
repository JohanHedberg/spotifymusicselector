import { createStyles, Theme } from '@material-ui/core';

const styles = ({ palette, spacing, breakpoints }: Theme) => createStyles({
    root: {

    },
    paper: {
        padding: 20,
        maxWidth: 700,
        marginLeft: 'auto',
        marginRight: 'auto'
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

    },
    chipAvatar: {

    },
    slider: {
        padding: '22px 0px',
    }
});

export default styles;