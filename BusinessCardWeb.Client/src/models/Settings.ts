import Language from "./Language.js"

export default class Settings {
    _preloaderEnabled : boolean
    _navToggleEnabled : boolean
    _supportedLanguages : Language[]
    _apiUrls : string[]

    /** @constructs */
    constructor(jsonData) {
        this._preloaderEnabled = jsonData['preloaderEnabled']
        this._navToggleEnabled = jsonData['navToggleEnabled']
        this._supportedLanguages = jsonData['supportedLanguages'].map(
            ({ id, name, default: isDefault, flagUrl: flagUrl }) => new Language(id, name, isDefault, flagUrl)
        )
        this._apiUrls = jsonData['apiUrls']
    }

    /** @return {Boolean} */
    get preloaderEnabled() {
        return this._preloaderEnabled
    }

    /** @return {Language[]} */
    get supportedLanguages() {
        return this._supportedLanguages
    }

    /** @return {Boolean} */
    get navToggleEnabled() {
        return this._navToggleEnabled
    }

    /** @return {Array<string>} */
    get apiUrls() {
        return this._apiUrls
    }
}