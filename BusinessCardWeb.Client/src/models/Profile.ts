import Locales from "./Locales.js"
import ContactOption from "./ContactOption.js"
import JobAndService from "./JobAndService.js"

export default class Profile {
    _name : string
    _profilePictureUrl : string
    _locales : Locales
    _contactOptions : ContactOption[]
    _jobAndServices : JobAndService[]
    
    /** @constructs */
    constructor(jsonData) {
        this._name = jsonData["name"]
        this._profilePictureUrl = jsonData["profilePictureUrl"]
        this._locales = new Locales(jsonData["locales"])
        this._contactOptions = jsonData["contactOptions"].map(contactOptionData => {
            return new ContactOption(contactOptionData)
        })
        this._jobAndServices = jsonData["jobAndServices"].map(job=> new JobAndService(job))
    }

    /** @return {String} */
    get name() {
        return this._name
    }

    /** @return {String} */
    get profilePictureUrl() {
        return this._profilePictureUrl
    }

    /** @return {ContactOption[]} */
    get contactOptions() {
        return this._contactOptions
    }

    /** @return {ContactOption} */
    getContactOptionWithId(id) {
        return this.contactOptions.find(contactOption => contactOption.id === id)
    }

    /** @return {Locales} */
    get locales() {
        return this._locales
    }

    /** @return {JobAndService} */
    get jobAndServices() {
        return this._jobAndServices
    }
}