using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace PROG_PART_2
{
    public class respond
    {
        //constructor
        public respond(ArrayList reply, ArrayList ignore)
        {//start of constructor

            answers(reply);
            words(ignore);

        }//end of constructor




        // METHOD TO STORE IGNORE WORDS

        private void words(ArrayList ignoring)
        {//start

            //common ignore words
            string[] ignoreWords =
            {
                "a","about","above","across","after","afterwards","again",
                "against","all","almost","alone","along","already","also",
                "although","always","am","among","amongst","amount","an",
                "and","another","any","anyhow","anyone","anything","anyway",
                "anywhere","are","around","as","at","back","be","became",
                "because","become","becomes","becoming","been","before",
                "beforehand","behind","being","below","beside","besides",
                "between","beyond","both","but","by","can","cannot","could",
                "did","do","does","doing","done","down","during","each",
                "either","else","elsewhere","enough","etc","even","ever",
                "every","everyone","everything","everywhere","except","few",
                "first","for","former","formerly","from","further","had",
                "has","have","having","he","hence","her","here","hereafter",
                "hereby","herein","hereupon","hers","herself","him",
                "himself","his","how","however","i","if","in","indeed",
                "inside","instead","into","is","it","its","itself","last",
                "later","latter","latterly","least","less","lot","many",
                "may","me","meanwhile","might","more","moreover","most",
                "mostly","much","must","my","myself","name","namely",
                "neither","never","nevertheless","next","no","nobody",
                "none","noone","nor","not","nothing","now","nowhere","of",
                "off","often","on","once","one","only","or","other",
                "others","otherwise","ought","our","ours","ourselves","out",
                "outside","over","own","part","per","perhaps","please",
                "put","rather","re","same","see","seem","seemed","seeming",
                "seems","several","she","should","show","side","since","so",
                "some","somehow","someone","something","sometime",
                "sometimes","somewhere","still","such","take","than","that",
                "the","their","theirs","them","themselves","then","thence",
                "there","thereafter","thereby","therefore","therein",
                "thereupon","these","they","this","those","though","through",
                "throughout","thru","thus","to","together","too","toward",
                "towards","under","unless","until","up","upon","us","used",
                "very","via","was","we","well","were","what","whatever",
                "when","whence","whenever","where","whereafter","whereas",
                "whereby","wherein","whereupon","wherever","whether",
                "which","while","whither","who","whoever","whole","whom",
                "whose","why","will","with","within","without","would",
                "yes","yet","hey","you","your","yours","yourself",
                "yourselves"
            };

            //loop to add words
            foreach (string word in ignoreWords)
            {
                ignoring.Add(word);
            }

        }//end






        // METHOD TO STORE ANSWERS

        public void answers(ArrayList add_answers)
        {//start of method


            // GREETINGS

            add_answers.Add("greeting i'm doing well, thanks for asking! how are you doing today ?");
            add_answers.Add("greeting i'm great today, thanks for asking! how can i help you today ?");
            add_answers.Add("greeting doing good! hope you are also doing well today ?");
            add_answers.Add("greeting hello 👋 nice to meet you.");
            add_answers.Add("greeting welcome to the cybersecurity assistant.");




            // PURPOSE

            add_answers.Add("purpose my purpose is to educate you on how to stay safe online and guide your cybersecurity questions.");
            add_answers.Add("purpose i help users understand online safety and digital protection.");
            add_answers.Add("purpose i assist with cybersecurity awareness and safety guidance.");




            // CYBERSECURITY

            add_answers.Add("cybersecurity cybersecurity is about protecting systems and networks from digital threats.");
            add_answers.Add("cybersecurity it involves protecting devices and online accounts from attacks.");
            add_answers.Add("cybersecurity it focuses on securing digital information and systems.");




            // PHISHING

            add_answers.Add("phishing phishing is a scam where attackers pretend to be trusted sources to steal information.");
            add_answers.Add("phishing it uses fake messages or websites to trick users into revealing sensitive data.");
            add_answers.Add("phishing attackers use deception to make users believe they are legitimate.");




            // FIREWALL

            add_answers.Add("firewall a firewall controls network traffic based on security rules.");
            add_answers.Add("firewall it helps block unwanted access to your device or network.");
            add_answers.Add("firewall it acts as a protective barrier between trusted and untrusted networks.");




            // PASSWORD

            add_answers.Add("password a password is used to secure access to your accounts or devices.");
            add_answers.Add("password it should be strong, long and not easy to guess.");
            add_answers.Add("password avoid using personal details when creating one.");
            add_answers.Add("password use uppercase, lowercase, numbers and symbols.");




            // HACKED ACCOUNT

            add_answers.Add("hacked account immediately secure your account and log out of all devices.");
            add_answers.Add("hacked account contact support if your account has been compromised.");
            add_answers.Add("hacked account enable extra security like two-factor authentication.");




            // FRAUD

            add_answers.Add("fraud contact your bank immediately if fraud is detected.");
            add_answers.Add("fraud report suspicious financial activity to the authorities.");
            add_answers.Add("fraud monitor your accounts for unusual activity.");




            // MALICIOUS CHATBOT

            add_answers.Add("malicious chatbot malicious bots often create urgency to trick users.");
            add_answers.Add("malicious chatbot fake chatbots may ask for sensitive information.");
            add_answers.Add("malicious chatbot be cautious if a bot pressures you for personal data.");




            // VPN

            add_answers.Add("vpn a vpn helps protect your privacy on public wi-fi.");
            add_answers.Add("vpn it encrypts your internet traffic for safety.");
            add_answers.Add("vpn it improves security when using public networks.");




            // ANTIVIRUS

            add_answers.Add("antivirus antivirus software helps detect and remove harmful programs.");
            add_answers.Add("antivirus always keep your antivirus updated.");
            add_answers.Add("antivirus antivirus protects your computer from malware threats.");






            // MALWARE

            add_answers.Add("malware malware is harmful software designed to damage systems.");
            add_answers.Add("malware avoid downloading files from unknown websites.");
            add_answers.Add("malware malware can steal information from your device.");




            // TWO FACTOR AUTHENTICATION

            add_answers.Add("2fa two-factor authentication adds an extra layer of security.");
            add_answers.Add("2fa it helps protect accounts even if passwords are stolen.");
            add_answers.Add("2fa enable 2fa on important accounts whenever possible.");





            // SENTIMENT DETECTION


            //frustrated
            add_answers.Add("frustrated i understand you're frustrated. let's work through the issue step by step.");
            add_answers.Add("frustrated it's okay to feel frustrated when things aren't working. i'm here to help.");
            add_answers.Add("frustrated take a breath, we'll fix this together.");


            //confused
            add_answers.Add("confused that's okay, confusion is normal. i'll explain it clearly for you.");
            add_answers.Add("confused let me break it down step by step so it makes sense.");
            add_answers.Add("confused no worries, i'll help you understand it better.");


            //worried
            add_answers.Add("worried it's okay to feel worried. i'm here to help you stay safe online.");
            add_answers.Add("worried don't panic, most cybersecurity issues can be fixed quickly.");
            add_answers.Add("worried i understand your concern. let's make sure your information is safe.");


            //happy
            add_answers.Add("happy that's great to hear! i'm glad things are going well.");
            add_answers.Add("happy awesome! positivity is always good.");
            add_answers.Add("happy i'm happy for you! let me know if you need anything.");


            //sad
            add_answers.Add("sad i'm sorry you're feeling this way. i'm here for you.");
            add_answers.Add("sad that sounds tough, take things one step at a time.");
            add_answers.Add("sad i hope things improve soon. you can talk to me anytime.");


            //angry
            add_answers.Add("angry i understand you're angry. let's try solve the issue together.");
            add_answers.Add("angry it's okay to feel angry, but i'll help you fix the problem.");
            add_answers.Add("angry take your time, i'm here to help you sort it out.");




            // EXTRA SECURITY TOPICS


            add_answers.Add("scam avoid clicking suspicious links from unknown people.");
            add_answers.Add("scam online scams often pretend to offer rewards or urgent warnings.");
            add_answers.Add("scam always verify messages before responding.");


            add_answers.Add("wifi public wi-fi networks can be risky without protection.");
            add_answers.Add("wifi avoid accessing banking apps on public wi-fi.");
            add_answers.Add("wifi use a vpn when connected to public networks.");


            add_answers.Add("email avoid opening unknown email attachments.");
            add_answers.Add("email scammers often use fake emails to steal information.");
            add_answers.Add("email check the sender address carefully before replying.");


        }//end of method



    }
}
