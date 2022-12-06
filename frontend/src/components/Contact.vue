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