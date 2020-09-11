 const mongoose = require('mongoose');

 //Database schema and model
 const adminSchema = mongoose.Schema({
     name: {
        type: String,
        trim: true,
        unique: 1
     },
     password: {
        type: String, 
        minlength: 16
     }
 })

 const admin = mongoose.model('Admin', adminSchema)
 module.exports = { admin }