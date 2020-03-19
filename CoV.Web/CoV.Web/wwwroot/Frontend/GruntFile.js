module.exports = function(grunt) {
  grunt.initConfig({
    pkg: grunt.file.readJSON("package.json"),
    sass: {
      dist: {
        files: {
          "css/template.css" : "scss/template.scss",
          "css/customcss.css" : "scss/customcss.scss",
          "css/style.css" : "scss/style.scss",
        }
      }
    },
    // haml: {
    //   dist: {
    //     files: {
    //       "html/index.html" : "haml/index.haml",
    //       "html/admin/login.html" : "haml/**/login.haml",
    //       "html/admin/register.html" : "haml/**/register.haml",
    //     }
    //   }
    // },
    // cssmin: {
    //   target: {
    //     files: [{
    //       expand: true,
    //       cwd: 'css',
    //       src: ['*.css', '!*.min.css'],
    //       dest: 'css_min',
    //       ext: '.min.css'
    //     }]
    //   }
    // },
    // uglify:{
    //   target: {
    //     files: [{
    //       expand: true,
    //       cwd: 'js',
    //       src: ['*.js', '!*.min.js'],
    //       dest: 'js_min',
    //       ext: '.min.js'
    //     }]
    //   }
    // },
    watch: {
      css: {
        files:[
        "scss/*.scss",
        "*.sass",
        'scss/**/*.scss',
        "sass/*.sass",
        // "js/*.js"
        ],
        // tasks: ["sass","cssmin","uglify"]
        tasks: ["sass"]
      },
    }
  });
  grunt.loadNpmTasks("grunt-contrib-sass");
  grunt.loadNpmTasks("grunt-contrib-watch");
  // grunt.loadNpmTasks('grunt-contrib-haml');
  // grunt.loadNpmTasks('grunt-contrib-cssmin');
  // grunt.loadNpmTasks('grunt-contrib-jshint');
  // grunt.loadNpmTasks('grunt-contrib-uglify');
}

