import { approvalsConfig } from './approvals.config'

export function configure() {
    // eslint-disable-next-line no-undef
    const path = require('path')

    // eslint-disable-next-line no-undef
    const basePath = path.join(process.cwd(), 'test/mocha/approvals')

    // eslint-disable-next-line no-undef
    const approvals = require('approvals').configure(approvalsConfig)

    return {
        verify: ({ value = '', description = '' }) => approvals.verify(basePath, description.replace(/\s+/gi, "_"), value),
        verifyAsJSON: ({ value = {}, description = '' }) => approvals.verify(basePath, description.replace(/\s+/gi, "_"), JSON.stringify(value, null, 4))
    }
}