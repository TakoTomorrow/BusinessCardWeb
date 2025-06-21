import axios from 'axios';

export default class Article {
    constructor(baseUrl){
        this.instance = axios.create({
            baseURL: baseUrl,
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            }
        });
    }

    async getProfile(id){
        var response = await this._get("BusinessCard", id);

        return response.data;
    }

    async _get(url, id){
        try {
            const response = await this.instance.get(url + `?id=${id}`);
            return response.data;
        } catch (error) {
            console.error('Error fetching data:', error);
            throw error;
        }
    }
}