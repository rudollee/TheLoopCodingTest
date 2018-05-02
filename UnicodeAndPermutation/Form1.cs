using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeAndPermutation
{
	public partial class Form1 : Form
	{
		private List<string> Words = new List<string>();
		public Form1()
		{
			InitializeComponent();
			txtWord.Focus();
		}

		#region Show Permuted real words
		private async void ShowRealwords()
		{
			Words.Clear();
			Permute(txtWord.Text.ToCharArray());
			var wordFiltered = new List<string>();
			foreach (var word in Words)
			{
				var json = await GetWordsFromDic(word);
				if (json.Length - word.Length > 100)
				{
					wordFiltered.Add(word);
				}
			}

			if (wordFiltered.Any())
			{
				ListboxWords.DataSource = wordFiltered;
			}
		}
		#endregion

		#region Sum Unicode Numbers
		/// <summary>
		/// 받은 string의 각 character들의 Unicode 값을 구하여 합산함
		/// </summary>
		/// <param name="word"></param>
		private void SumUnicodeNumbers(string word)
		{
			int n = 0;
			foreach (var c in word)
			{
				n += (int)c;
			}

			lblSum.Text = n.ToString();
		}
		#endregion

		#region Permutation
		/// <summary>
		/// 1. 길이가 할당되지 않은 경우, 단어의 길이를 계산
		/// 2. 새롭게 조합된 string을 collection에 추가
		/// 3. 재귀적으로 Permute 함수를 호출하여 새로운 조합을 찾아냄
		/// </summary>
		/// <param name="chars"></param>
		/// <param name="k"></param>
		/// <param name="length"></param>
		private void Permute(char[] chars, int k = 0, int length = -1)
		{
			if (length == -1)
			{
				length = chars.Length;
			}

			if (k == length)
			{
				Words.Add(new string(chars));
				Words = Words.Distinct().ToList();
				return;
			}

			for (int i = k; i < length; i++)
			{
				Swap(ref chars[k], ref chars[i]);
				Permute(chars, k + 1, length);
				Swap(ref chars[k], ref chars[i]);
			}
		}

		/// <summary>
		/// XOR Opertation을 이용하여 두 character를 치환
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		private void Swap(ref char a, ref char b)
		{
			if (a == b) return;

			a ^= b;
			b ^= a;
			a ^= b;
		}
		#endregion

		#region Get word information via open api
		/// <summary>
		/// https://glosbe.com/gapi/translate?from=eng&dest=eng&format=json&pretty=false&phrase= ?
		/// 비동기적으로 단어의 뜻을 json 파일로 받아서 return
		/// </summary>
		/// <param name="word"></param>
		/// <returns>Json format</returns>
		private async Task<string> GetWordsFromDic(string word)
		{
			using (var client = new WebClient())
			{
				var uri = new Uri($"https://glosbe.com/gapi/translate?from=eng&dest=eng&format=json&pretty=false&phrase={word}");
				return await client.DownloadStringTaskAsync(uri);
			}
		}
		#endregion

		#region Events
		private void buttonPorcess_Click(object sender, EventArgs e)
		{
			SumUnicodeNumbers(txtWord.Text);
			ShowRealwords();
		}

		private void txtWord_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyData)
			{
				case Keys.Enter:
					SumUnicodeNumbers(txtWord.Text);
					ShowRealwords();
					break;
			}
		}
		#endregion
	}
}
