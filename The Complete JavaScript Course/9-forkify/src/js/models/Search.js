import axios from 'axios';

export default class Search {
    constructor(query) {
        this.query = query;
    }

    async getResults() {
        const proxy = 'http://cors-anywhere.herokuapp.com/';
        const key = 'c240889fc3956cfb2276b0d266ef065e';
        try {
            const res = await axios(`${proxy}https://www.food2fork.com/api/search?key=${key}&q=${this.query}`);
            this.result = res.data.recipes;
            //console.log(this.result);
        } catch (error) {
            alert(error)
        }
    }
}
