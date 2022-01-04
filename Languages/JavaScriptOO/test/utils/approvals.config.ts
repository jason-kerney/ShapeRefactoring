export const approvalsConfig = {
    reporters: ['beyondcompare', 'kdiff3', 'vscode'],

    normalizeLineEndingsTo: '\r\n',

    appendEOL: true,

    EOL: "\r\n",

    errorOnStaleApprovedFiles: true,

    shouldIgnoreStaleApprovedFile: function (/*fileName*/) { return false },

    blockUntilReporterExits: true,
    
    stripBOM: true,

    forceApproveAll: false
}