<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
>
    <xsl:template match="/">
      <html>
        <style>
          table {
          border-collapse: collapse;
          }

          table, th, td {
          border: 1px solid black;
          }

          #exam div:not(:first-child) {
          border-top: 1px solid;
          }

          th, td {
          text-align: center;
          padding: 15px;
          }

          th {
          background: #EEE;
          }

          tr:nth-child(even) {
          background: #CCC
          }

          tr:nth-child(odd) {
          background: #FFF
          }
        </style>
        <body>
          <h1>XSLT Stylesheet Example</h1>
          <table>
            <tr>
              <th>Name</th>
              <th>Gender</th>
              <th>Birth date</th>
              <th>Phone</th>
              <th>Email</th>
              <th>Course</th>
              <th>Specialty</th>
              <th>Faculty number</th>
              <th>Enrollment</th>
              <th>Taken exams</th>
            </tr>
            <xsl:for-each select="students/student">
              <tr>
                <td>
                  <xsl:value-of select="name"/>
                </td>
                <td>
                  <xsl:value-of select="gender"/>
                </td>
                <td>
                  <xsl:value-of select="birthDate"/>
                </td>
                <td>
                  <xsl:value-of select="phone"/>
                </td>
                <td>
                  <xsl:value-of select="email"/>
                </td>
                <td>
                  <xsl:value-of select="course"/>
                </td>
                <td>
                  <xsl:value-of select="specialty"/>
                </td>
                <td>
                  <xsl:value-of select="facultyNumber"/>
                </td>

                  <td>
                    <div>
                      <p>
                        <span>Enrollment: </span>
                        <xsl:value-of select="enrollment/date"/>
                      </p>
                      <p>
                        <span>Exam Score: </span>
                        <xsl:value-of select="enrollment/examScore"/>
                      </p>
                      <p>
                        <span>Endorsements: </span>
                        <xsl:value-of select="enrollment/endorsements"/>
                      </p>
                    </div>
                  </td>
                
                <td id="exam">
                  <xsl:for-each select="takenExams/exam">
                    <div>
                      <p>
                        <span>Name: </span>
                        <xsl:value-of select="name"/>
                      </p>
                      <p>
                        <span>Tutor: </span>
                        <xsl:value-of select="tutor"/>
                      </p>
                      <p>
                        <span>Score: </span>
                        <xsl:value-of select="score"/>
                      </p>
                    </div>
                  </xsl:for-each>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
