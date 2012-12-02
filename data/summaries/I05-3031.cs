As the taskisanimportantprecursortomanynaturallanguage processing systems, it receives a lot of attentions in the literature for the past decade (Wu and Tseng, 1993; Sproat et al., 1996).
J96-3004
Note that the original tag set used by (Xue and Shen, 2003) is simplified and improved by (Ng and Low, 2004). We shall then adopt and illustrate the simplified case here.
W03-1728 W04-3236
Feature Type Example – Features extracted of character “_d_932” 1 Characters within window of±2 C−2=“3”, C−1=“2”, C0=“_d_932”, C1=“_d_9838”, C2=“_d_4766” 2 Two consecutive characters within window of±2 C−2C−1=“32”, C−1C0=“2_d_932”, C0C1=“_d_932_d_9838”, C1C2=“_d_9838_d_4766” 3 Previous and next characters C−1C1=“ 2_d_9838” 4 Current character is punctuation – 5 ASCII characters within window of±2 A−2,A−1 (as “3” and “2” are ASCII) 6 Current and character in window±1 belong to different types D−1 (as “2” is digit, but “ _d_932” is letter) Additional feature templates as compared to (Xue and Shen, 2003) and (Ng and Low, 2004) are template 5 and 6.
W03-1728 W04-3236
In Section 2, we briefly discuss the scheme proposed by (Xue and Shen, 2003), followed by our additional works to improve the performance.
W03-1728
In this paper, we propose a statistical approach based on the works of (Xue and Shen, 2003), in which the Chinese word segmentation problem is first transformed into a tagging problem, then the Maximum Entropy classifier is applied to solve the problem.
W03-1728
Proposed Approach 2.1 Chinese Word Segmentation as Tagging One of the difficulties in Chinese word segmentation is that, Chinese characters can appear in different positions within a word (Xue and Shen, 2003), and LMR Tagging was proposed to solve the problem.
W03-1728
Della Pietra, 1996; Ratnaparkhi, 1996) was proposed in the original work to solve the LMR Tagging problem.
W96-0213
