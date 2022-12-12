<template>
  <header>

  <form ref="form" @submit.prevent="sendEmail">
    <div>
      <input type="text" placeholder="Your name" name="from_name" required />
    </div>

    <div>
      <input type="email" placeholder="Email" name="email_id" required />
    </div>

    <div>
      <textarea placeholder="Your message" name="message" required />
    </div>

    <div>
      <button type="submit">Send a message</button>
    </div>
  </form>
  </header>
</template>

<script>
import emailjs from '@emailjs/browser';

export default {


methods: {
    sendEmail() {
      emailjs.sendForm('service_a4fm5kk', 'template_33hrwsq', this.$refs.form, 'gflxB7s4eEVe0yG89')
        .then((result) => {
            console.log('SUCCESS!', result.text);
        }, (error) => {
            console.log('FAILED...', error.text);
        });
    }
  }

};
</script>

<style scoped>
.contactform-form {
  font-size: 16px;
  width: 500px;
  padding: 15px 30px;
  border-radius: 4px;
  margin: 50px auto;
  width: 52vw;
  background-color: #fff;
  box-shadow: 0 4px 6px 0 rgba(0, 0, 0, 0.3);
}

.contactform-form fieldset {
  margin: 24px 0 0 0;
}

.contactform-form div {
  position: relative;
  margin: 20px 0;
}

.contactform-form input[type="text"],
.contactform-form input[type="email"],
.contactform-form textarea,
.contactform-form select {
  padding: 12px;
  border: 1px solid #cfd9db;
  background-color: #ffffff;
  border-radius: 0.25em;
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.08);
}

.contactform-form textarea {
  min-height: 120px;
  resize: vertical;
  overflow: auto;
}

.contactform-form .label {
  display: block;
}

.contactform-form h4,
.contactform-form .label {
  color: #000000;
  margin-bottom: 10px;
}

form.contactform-form textarea#textarea {
  margin-left: 61px;
  padding: 18px;
}
form.contactform-form input[type="submit"] {
    background-image: none;
    background: #1979c3;
    border: 1px solid #1979c3;
    color: #fff;
    cursor: pointer;
    display: inline-block;
    font-family: 'Open Sans','Helvetica Neue',Helvetica,Arial,sans-serif;
    font-weight: 600;
    padding: 6px 12px;
    font-size: 18px;
    box-sizing: border-box;
    vertical-align: middle;
}
</style>