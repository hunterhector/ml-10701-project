To the research field of Chinese speech recognition, the STW conversion is the main task of Chinese language processing in typical Chinese speech recognition systems (Fu et al.1996, Lee et al.1993, Chien et al.1993, Su et al.1992). Conventionally, there are two approaches for syllable-to-word (STW) conversion: (1) the linguistic approach based on syntax parsing, se9 mantic template matching and contextual information (Hsu 1994, Fu et al.1996, Hsu et al.1999, Kuo 1995, Tsai and Hsu 2002); and (2) the statistical approach based on the n-gram models where n is usually 2 or 3 (Lin and Tsai 1987, Gu et al.1991, Fu et al.1996, Ho et al.1997, Sproat 1990, Gao et al.2002, Lee 2003).
C02-1089
According to previous studies (Chung 1993, Fong and Chung 1994, Tsai and Hsu 2002, Gao et al.2002, Lee 2003), homophone selection and syllable-word segmentation are two critical problems to the STW conversion in Chinese.
C02-1089
The UDN2001 corpus (Tsai and Hsu 2002) is a collection of 4,539,624 Chinese sentences extracted from whole 2001 articles on the United Daily News Website (UDN) in Taiwan.
C02-1089
For example, consider the syllable sequence “yi1 du4 ji4 yu2 zhong1 guo2 de5 niang4 jiu3 ji4 shu4” of the sentence “�.N(once)YTYN(covet)�&�(China)F,(of)ah`� (making-wine)2(W�(technique).?As per the MOE-MANDARIN dictionary, the two possible syllable-word segmentations (in pinyin) are: (F)“yi1/du4ji4/yu2/zhong1guo2/de5/niang4ji u3/ji4shu4”; and (B)“yi1/du4/ji4yu2/zhong1guo2/de5/niang4ji u3/ji4shu4.” (We use the forward (F) and the backward (B) longest syllable-word first strategies (Chen et al.1986, Tsai and Hsu 2002), and “/” to indicate a syllable-word boundary).
C02-1089
More than 100 Chinese input methods have been developed in the past (Becker 1985, Huang 1985, Gu et al.1991, Chung 1993, Kuo 1995, Fu et al.1996, Lee et al.1997, Hsu et al.1999, Chen et al.2000, Tsai and Hsu 2002, Gao et al.2002, Lee 2003).
C02-1089
Since the size of problem space for syllable-to-word conversion is much less than that of syllable-to-character conversion, the most existing Chinese input systems (Hsu 1994, Hsu et al.1999, Tsai and Hsu 2002, Gao et al.2002, MSIME) are addressed on syllable-toword conversion, not syllable-to-character conversion.
C02-1089
Although the linguistic approach requires considerable effort in designing effective syntax rules, semantic templates or contextual information, it is more user-friendly than the statistical approach on understanding why such a system makes a mistake (Hsu 1994, Tsai and Hsu 2002).
C02-1089
